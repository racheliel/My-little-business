from google.appengine.api import users
from google.appengine.ext import ndb

class SaleEvents(ndb.Model):
	email = ndb.StringProperty()
	
	
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
			
	def getAllEventForAllUser(self):
		allUser = User.getAllUser()
		allEvent=[]
		if allUser:
			for user in allUser:
				allEvent.append(user)
			return allUser
		else
			return None
	