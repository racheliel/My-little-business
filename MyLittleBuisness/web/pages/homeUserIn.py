from google.appengine.api import users
from google.appengine.ext.webapp import template
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
from models.user import User
import HTML
=======

from models.user import User
>>>>>>> parent of 516a02a... login g
=======

from models.user import User
>>>>>>> parent of 516a02a... login g
=======

from models.user import User
>>>>>>> parent of 516a02a... login g
import webapp2

class IndexHandler(webapp2.RequestHandler):
	def get(self):
		template_params = {}
		user = None
		if self.request.cookies.get('session'):
			user = User.checkToken(self.request.cookies.get('session'))
		if not user:
			self.redirect('/')
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		
		myEmail = user.email

		template_params['emailUser'] = myEmail
				
=======
=======
>>>>>>> parent of 516a02a... login g
=======
>>>>>>> parent of 516a02a... login g
        myEmail = user.email
        template_params['emailUser'] = myEmail
            
>>>>>>> parent of 516a02a... login g
            
		html = template.render("web/templates/homeUserIn.html", template_params)
		self.response.write(html)

app = webapp2.WSGIApplication([
	('/homeUserIn', IndexHandler)
], debug=True)
