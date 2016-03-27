from google.appengine.ext.webapp import template
from models.user import User
import webapp2
import json

class DefaultHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		if self.request.cookies.get('session'):    
			user = User.checkToken(self.request.cookies.get('session'))
			self.redirect('/homeUserIn')
			return
		email = self.request.get('email')
		user = None
		if email:
			self.response.write(json.dumps({'status':'OK'}))
			user = User.checkIfUserExists(email)
			if user:
				self.response.set_cookie('session', str(user.key.id()))
				self.redirect('/homeUserIn')
				return
			else:
				user = User.addUser(email)
				self.redirect('/homeUserIn')
				self.response.set_cookie('session', str(user.key.id()))
				return
		else:
			html = template.render("web/templates/home.html", template_params)
			self.response.write(html)



app = webapp2.WSGIApplication([
	('/', DefaultHandler),
	('/home', DefaultHandler)
], debug=True)
