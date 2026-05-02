class student :
    """A class representing a student
    """
    def __init__(self,name,age):
        self.full_name = name
        self.age = age

    def get_age(self):
        return self.age


ben = student("Ben",22)
print(ben.get_age())
del ben