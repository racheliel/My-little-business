from google.appengine.ext import ndb

class User(ndb.Model):
	email = ndb.StringProperty(required=True)
	GroupID = ndb.IntegerProperty()
	
	@staticmethod
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
	


	@classmethod
	def getAllUserGroups(self,user_name):
		userGroups =[]
		
		query = User.query(User.email == user_name).fetch()
		if query:
			for group in query:
				userGroups.append(group)
				
			return userGroups
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
=======
=======
>>>>>>> parent of 516a02a... login g
=======
>>>>>>> parent of 516a02a... login g
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
>>>>>>> parent of 516a02a... login g
	

			
