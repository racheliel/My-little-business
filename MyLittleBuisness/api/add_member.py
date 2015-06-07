import webapp2
import json
import logging
from models.user import User
from models.page import Page

import time

class CreatePage(webapp2.RequestHandler):
    def get(self):
        page = Page.get_by_id(int(self.request.get('page_id')))
        user = None
        if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
            user = User.checkToken(self.request.cookies.get('our_token'))

        if not user or page.admin != user.key:
            self.error(403)
            self.response.write('access denied')
            return

        new_user_email = self.request.get('member_email')
        logging.info("Email {}".format(new_user_email))
        new_user = User.query(User.email == new_user_email).get()

        if not new_user:
            self.error(404)
            self.response.write('User with email {} not found'.format(new_user_email))
            return

        page.members.append(new_user.key)
        page.put()
        members = page.getMembers()

        time.sleep(0.5)
        self.response.write(json.dumps({"status": "OK", "members": members}))

app = webapp2.WSGIApplication([
    ('/api/add_member', CreatePage)
], debug=True)
