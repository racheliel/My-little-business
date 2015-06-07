from google.appengine.ext.webapp import template
import webapp2
import json
from models.user import User
from models.page import Page

import time

class createPageBus(webapp2.RequestHandler):
    def get(self):
        user = None
        if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
            user = User.checkToken(self.request.cookies.get('our_token'))

        if not user:
            self.error(403)
            self.response.write('No user - access denied')
            return

        page = Page()
        page.title = self.request.get('title')
        page.admin = user.key
        page.put()
        time.sleep(0.5)
        pages = Page.getAllPages(user)
        self.response.write(json.dumps({"status": "OK", "pages": pages}))

app = webapp2.WSGIApplication([
    ('/api/createPageBus', createPageBus)
], debug=True)
