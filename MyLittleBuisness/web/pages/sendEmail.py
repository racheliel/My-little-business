#from google.appengine.api import users
from google.appengine.ext.webapp import template

from models.user import User
import webapp2

class IndexHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		user = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
			myEmail = user.email
			template_params['emailUser'] = myEmail
			
		if not user:
			self.redirect('/')
		
		html = template.render("web/templates/sendEmail.html", template_params)
		self.response.write(html)

app = webapp2.WSGIApplication([
	('/sendEmail', IndexHandler)
], debug=True)
