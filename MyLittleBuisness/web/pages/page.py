from google.appengine.ext.webapp import template
from models.user import User
from models.page import Page
import webapp2
import json



class PageHandler(webapp2.RequestHandler):
    def get(self, page_id):
		template_params = {}
		user = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
		if not user:
			self.redirect('/')
		
		myEmail = user.email

		template_params['email'] = myEmail
						
		html = template.render("web/templates/page.html", template_params)
		self.response.write(html)
       


app = webapp2.WSGIApplication([
	('/pages/(.*)', PageHandler),
], debug=True)
