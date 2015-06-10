from google.appengine.ext.webapp import template
from models.user import User
from models.event import Event
import webapp2


class IndexHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		user = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
		if not user:
			self.redirect('/')
		
		template_params['email'] = user.email
#		template_params['title'] = event.title
#		template_params['date'] = event.date
#		template_params['place'] = event.place
#		template_params['category'] = event.category
        
		html = template.render("web/templates/myPageEvent.html", template_params)
		self.response.write(html)
       

app = webapp2.WSGIApplication([
	('/myPageEvent', IndexHandler)
], debug=True)
