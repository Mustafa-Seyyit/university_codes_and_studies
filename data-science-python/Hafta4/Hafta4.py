class Student:
    """ A class representing a student """
    def __init__(self, n, a):
        self.full_name = n
        self.age = a

    def get_age(self):
        return self.age
    def set_age(self, num):
        self.age = num

b = Student("Bob", 10)
b.set_age(24)

f = Student("Bob murmur", 23)
f.full_name = "Bob Smith"
