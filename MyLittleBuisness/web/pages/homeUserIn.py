from google.appengine.api import users
from google.appengine.ext.webapp import template

from models.user import User
import webapp2

class IndexHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
#		user = "racheli"
#		if not user:
#			template_params['login'] = User.login()
#			html = template.render("web/templates/sign.html", template_params)
#		else:
#			template_params['logout'] = User.logout()
#			template_params['user'] = user.email
			html = template.render("web/templates/homeUserIn.html", template_params)
	
		self.response.write(html)

app = webapp2.WSGIApplication([
	('/homeUserIn', IndexHandler)
], debug=True)
