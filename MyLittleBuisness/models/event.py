from google.appengine.ext import ndb
import user

class Event(ndb.Model):
    title = ndb.StringProperty(required=True)
    date = ndb.StringProperty(required=True)
    place = ndb.StringProperty(required=True)
    category = ndb.StringProperty(required=True)
    admin = ndb.KeyProperty(required=True)
    members = ndb.KeyProperty(repeated=True)

    def getMembers(self):
        members = []
        for member in self.members:
            members.append({"email":member.get().email})

        return members

	@staticmethod
	def addEvent(_title,_date,_place,_category):
		event = Event()
		event.title = _title
		event.date = _date
		event.category = _category
		event.put()
		return event
		
		
#	@staticmethod
#	def checkToken(token):
#		event = Event.get_by_id(long(token))
#		return event

    @staticmethod
    def getAdminEvent(user_name):
        q = Event.query(Event.members == user_name)
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