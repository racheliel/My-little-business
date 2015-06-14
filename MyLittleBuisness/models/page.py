from google.appengine.ext import ndb
from models.user import User

class Page(ndb.Model):
    title = ndb.StringProperty()
    name = ndb.StringProperty()
    address = ndb.StringProperty()
    details = ndb.StringProperty()                  
    emailBuss = ndb.StringProperty()  
    admin = ndb.KeyProperty()
    members =  ndb.KeyProperty()
    
    @staticmethod
    def addPage(_title,_name,_address,_details,_email,_admin):
        page = Page()
        page.title = _title
        page.name = _name
        page.address = _address        
        page.details = _details
        page.emailBuss = _email
        page.admin=_admin
        page.put()
        return page 
	

    @classmethod		
    def deleteUser(self,user_name):
        query = User.query(User.email == user_name).fetch()
        for user in query:
            user.key.delete()

    def getMembers(self):
        members = []
        for member in self.members:
            members.append({"email":member.get().email})

        return members


    @staticmethod
    def getAdminPages(user):
        q = Page.query(Page.admin == user.key)
        pages_arr = []
        for page in q:
            pages_arr.append({
                "title": page.title,
                "id": page.key.id(),
                "admin": True
            })

        return pages_arr

    @staticmethod
    def getUserPages(user):
        q = Page.query(Page.members == user.key)
        pages_arr = []
        for page in q:
            pages_arr.append({
                "title": page.title,
                "id": page.key.id(),
                "admin": False
            })

        return pages_arr

        

    @staticmethod
    def getAllPages(user):
        arr_a = Page.getAdminPages(user)
        arr_b = Page.getUserPages(user)

        return arr_a + arr_b
    @staticmethod
    def getPageUser(user,title):
        allPage = Page.getAllPages(user)
        if allPage:
            for page in allPage:
                if(page.title == title)
                    return page
        else:
            return None
    @staticmethod            
    def checkIfPageExists(page.title,user.email):
        