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
		template_params['title'] = page.title
		template_params['details'] = page.details
		template_params['address'] = page.address
		template_params['name'] = page.name
		template_params['emailBuss'] = page.emailBuss 
        
		html = template.render("web/templates/myPage.html", template_params)
		self.response.write(html)
       

app = webapp2.WSGIApplication([
	('/myPage', IndexHandler)
], debug=True)
