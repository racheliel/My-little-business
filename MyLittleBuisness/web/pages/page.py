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
           self.redirect('/')

       template_params['email'] = user.email

       page = Page.get_by_id(int(page_id))
       if page.admin != user.key and user.key not in page.members:
           template_params['no_access'] = True
        else:
           template_params['page_title'] = page.title
           template_params['page_admin'] = page.admin.get().email
           template_params['page_id'] = page_id



        html = template.render('web/templates/page.html', template_params)
        self.response.write(html)

app = webapp2.WSGIApplication([
	('/pages/(.*)', PageHandler),
], debug=True)
