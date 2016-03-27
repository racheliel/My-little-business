from google.appengine.ext.webapp import template
from models.user import User
from models.event import Event
import webapp2
import json



class PageHandler(webapp2.RequestHandler):
    def get(self, event_id):
		template_params = {}
		user = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
		if not user:
			self.redirect('/')
		
		myEmail = user.email

		template_params['email'] = myEmail
						
		html = template.render("web/templates/event.html", template_params)
		self.response.write(html)
       


app = webapp2.WSGIApplication([
	('/events/(.*)', PageHandler),
], debug=True)
