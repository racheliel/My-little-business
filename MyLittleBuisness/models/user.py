from google.appengine.ext import ndb
import event
class User(ndb.Model):
	email = ndb.StringProperty(required=True)
	
	@staticmethod
	def checkToken(token):
		user = User.get_by_id(long(token))
		return user
	

	@staticmethod
	def checkIfUserExists(user_name):
		query = User.query(User.email == user_name).get()
		if query:
			return query
		else:
			return None
	

	@staticmethod
	def addUser(user_email):
		user = User()
		user.email = user_email
		user.put()
		return user 
	

	@classmethod		
	def deleteUser(self,user_name):
		query = User.query(User.email == user_name).fetch()
		for user in query:
			user.key.delete()
			
	@classmethod
	def getAllUsers(self):
		allUsers = []
		query = User.query(projection=[User.email],distinct=True).fetch()
		if query:
			for us in query:
				allUsers.append(us.email)
			return allUsers
		else:
			return None
	
	@classmethod			
	def getAllEventForUser(self, user_name):
		userEvent =[]	
		query = User.query(User.email == user_name).fetch()
		if query:
			for event in query:
				userEvent.append(event)			
			return userEvent
		else:
			return None

