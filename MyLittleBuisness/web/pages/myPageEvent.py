from google.appengine.ext.webapp import template
from models.user import User
from models.event import Event
import webapp2


class IndexHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		user = None
		#event = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
			#event = Event.checkToken(self.request.cookies.get('session'))
		if not user:
			self.redirect('/')
		
		
		
		Email = user.email
		template_params['email'] = Email 	
	#	Title = event.title
	#	Date = event.date
	#	Place = event.place
	#	Category = event.category
	#	template_params['title'] = Title
	#	template_params['date'] = Date
	#	template_params['place'] = Place
	#	template_params['category'] = Category
        
		html = template.render("web/templates/myPageEvent.html", template_params)
		self.response.write(html)
       

app = webapp2.WSGIApplication([
	('/myPageEvent', IndexHandler)
], debug=True)
