from google.appengine.ext.webapp import template
from models.user import User
import webapp2


class IndexHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		user = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
		if not user:
			self.redirect('/')
		
		myEmail = user.email

		template_params['email'] = myEmail
						
		html = template.render("web/templates/homeUserIn.html", template_params)
		self.response.write(html)
       
class LogoutHandler(webapp2.RequestHandler):
    def get(self):
        self.response.delete_cookie('session')
        self.redirect('/home')
        

app = webapp2.WSGIApplication([
	('/homeUserIn', IndexHandler),
    ('/logout', LogoutHandler)
], debug=True)
