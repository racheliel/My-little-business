from google.appengine.ext.webapp import template
from models.user import User
from models.page import Page
import webapp2
import json



class PageHandler(webapp2.RequestHandler):
    def get(self, page_id):
        template_params = {}
        user = None
	if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
           user = User.checkToken(self.request.cookies.get('our_token'))

	if not user:
           self.redirect('/home')

	template_params['email'] = user.email


        html = template.render('web/templates/home.html', template_params)
        self.response.write(html)

app = webapp2.WSGIApplication([
	('/pages/(.*)', PageHandler),
], debug=True)
