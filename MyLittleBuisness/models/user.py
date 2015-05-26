from google.appengine.api import users
from google.appengine.ext import ndb

class User(ndb.Model):
	email = ndb.StringProperty()

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
		
	@staticmethod
	def checkUser():
		googleUser = users.get_current_user()
		if not googleUser:
			return False
		
		user = User.query(User.email == googleUser.email()).get()
		if user:
			return user
		
		return False
	
	@staticmethod
	def loginUrl():
		return users.create_login_url('/connect')
	
	
	@staticmethod
	def logoutUrl():
		return users.create_logout_url('/')
	
	@staticmethod
	def connect():
		googleUser = users.get_current_user()
		if googleUser:
			user = User()
			user.email = googleUser.email()
			user.put()
			return user

		else:
			return "not connected"