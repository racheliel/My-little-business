from google.appengine.ext.webapp import template
from models.user import User
from models.page import Page
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

		template_params['email'] = myEmail
        title = self.request.get('page_title')
        address = self.request.get('page_address')   
        name = self.request.get('page_name')
        emailBuss = self.request.get('page_emailBuss')   
        details = self.request.get('page_details')
          
        page=None
        
        if title and address and name and emailBuss and details:
			self.response.write(json.dumps({'status':'OK'}))
			page = Page.addPage(title,address,name,emailBuss,details)
			self.redirect('/page')
			self.response.set_cookie('session', str(user.key.id()))
			return
		else:
			html = template.render("web/templates/myPage.html", template_params)
			self.response.write(html)
       

app = webapp2.WSGIApplication([
	('/myPage', IndexHandler)
], debug=True)
