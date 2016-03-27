from google.appengine.ext.webapp import template
from models.user import User
from google.appengine.api import users
from google.appengine.ext import ndb
import webapp2

class DefaultHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		email = ''
		googleUser = users.get_current_user()
		if googleUser:
			email = googleUser.email()

		self.response.write('email is ' + email)

app = webapp2.WSGIApplication([
	('/loginGoogle', DefaultHandler)
], debug=True)
