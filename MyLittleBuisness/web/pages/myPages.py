from google.appengine.ext.webapp import template
from models.user import User
from models.pages import pages
import webapp2



class AllGroupsHandler(webapp2.RequestHandler):
    def get(self):
        self.redirect('/')
        return

class GroupHandler(webapp2.RequestHandler):
    def get(self, group_id):
        template_params = {}
        user = None
        if self.request.cookies.get('our_token'):    #the cookie that should contain the access token!
            user = User.checkToken(self.request.cookies.get('our_token'))

        if not user:
            self.redirect('/')

        template_params['email'] = user.email

        group = Group.get_by_id(int(group_id))
        if group.admin != user.key and user.key not in group.members:
            template_params['no_access'] = True
        else:
            template_params['buss_title'] = group.title
            template_params['group_admin'] = group.admin.get().email
            template_params['group_id'] = group_id



        html = template.render('web/templates/myPages.html', template_params)
        self.response.write(html)

app = webapp2.WSGIApplication([
	('/myPages/(.*)', GroupHandler),
], debug=True)
