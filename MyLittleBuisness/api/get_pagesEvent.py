from google.appengine.ext.webapp import template

import webapp2
import json
from models.user import User
from models.event import Event

class Getevents(webapp2.RequestHandler):
    def get(self):
        user = User.checkToken(self.request.cookies.get('session'))
        if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
            user = User.checkToken(self.request.cookies.get('our_token'))

        if not user:
            self.error(403)
            self.response.write('No user - access denied')
            return
        
        events = Event.getAllEvent(user)
        self.response.write(json.dumps({"status": "OK", "events": events}))


app = webapp2.WSGIApplication([
    ('/api/get_pagesEvent', Getevents)
], debug=True)
