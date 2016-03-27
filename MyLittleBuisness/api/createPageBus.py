from google.appengine.ext.webapp import template
import webapp2
import json
from models.user import User
from models.page import Page

import time

class createPageBus(webapp2.RequestHandler):
    def get(self):
        user = User.checkToken(self.request.cookies.get('session'))
		
        if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
            user = User.checkToken(self.request.cookies.get('our_token'))

        if not user:
            self.error(403)
            self.response.write('No user - access denied')
            return
            
        page = None
        page.title = self.request.get('title')
        page.name = self.request.get('name')
        page.address = self.request.get('address')
        page.details = self.request.get('details')
        page.emailBuss = self.request.get('emailBuss')        
        page.admin = user.key            
        
		if page:
			if Page.checkIfPageExists(page.title,user.email):
				self.response.write(json.dumps({'status':'exists'}))
				return
			else:
				page = Page.addPage(page.title,page.name,page.address,page.details,page.emailBuss,page.admin)
				time.sleep(0.5);

 #       page.put()
 #       time.sleep(0.5)
        pages = Page.getAllPages(user)
        self.response.write(json.dumps({"status": "OK", "pages": pages}))

app = webapp2.WSGIApplication([
    ('/api/createPageBus', createPageBus)
], debug=True)
