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
		if not user:
			self.redirect('/')
		
		myEmail = user.email

		template_params['emailUser'] = myEmail

		html = template.render("web/templates/myBusiness.html", template_params)
		self.response.write(html)

app = webapp2.WSGIApplication([
	('/myBusiness', IndexHandler)
], debug=True)
