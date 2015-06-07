from google.appengine.ext.webapp import template
import webapp2
import json
from models.user import User
from models.page import Page

class GetPages(webapp2.RequestHandler):
    def get(self):
        page = Page.get_by_id(int(self.request.get('page')))
        user = None
        if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
            user = User.checkToken(self.request.cookies.get('our_token'))

        if not user or (page.admin != user.key and user.key not in page.members):
            self.error(403)
            self.response.write('access denied')
            return

        members = page.getMembers()
        self.response.write(json.dumps({"status": "OK", "members": members}))


app = webapp2.WSGIApplication([
    ('/api/members', GetPages)
], debug=True)
