from google.appengine.ext import ndb

class Page(ndb.Model):
    title = ndb.StringProperty()
    admin = ndb.KeyProperty()
    members = ndb.KeyProperty(repeated=True)

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