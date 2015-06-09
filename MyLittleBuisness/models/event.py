from google.appengine.ext import ndb

class Event(ndb.Model):
    title = ndb.StringProperty()
    date = ndb.StringProperty()
    place = ndb.StringProperty()
    category = ndb.StringProperty()
    admin = ndb.KeyProperty()
    members = ndb.KeyProperty(repeated=True)

    def getMembers(self):
        members = []
        for member in self.members:
            members.append({"email":member.get().email})

        return members


    @staticmethod
    def getAdminEvent(user):
        q = Event.query(Event.admin == user.key)
        events_arr = []
        for event in q:
            events_arr.append({
                "title": event.title,
                "date" : event.date,
                "place" : event.place,
                "category" : event.category,
                "id": event.key.id(),
                "admin": True
            })

        return events_arr

    @staticmethod
    def getUserEvent(user):
        q = Event.query(Event.members == user.key)
        events_arr = []
        for event in q:
            events_arr.append({
                "title": event.title,
                "date" : event.date,
                "place" : event.place,
                "category" : event.category,
                "id": event.key.id(),
                "admin": False
            })

        return events_arr

    @staticmethod
    def getAllEvent(user):
        arr_a = Event.getAdminEvent(user)
        arr_b = Event.getUserEvent(user)

        return arr_a + arr_b