from google.appengine.ext import ndb

class Page(ndb.Model):
    title = ndb.StringProperty()
    name = ndb.StringProperty()
    address = ndb.StringProperty()
    details = ndb.StringProperty()                  
    emailBuss = ndb.StringProperty()  
    admin = ndb.KeyProperty()
    members =  ndb.KeyProperty()
    
    	@staticmethod
	def addPage(title,name,address,details,email):
		page = Page()
		page.title = title
		page.name = name
		page.address = address        
		page.details = details
		page.emailBuss = email
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