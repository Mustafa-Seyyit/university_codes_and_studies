class Circle:
    def __init__(self,radius):
        """Initializes self with radius"""
        self.radius = radius
    def get_radius(self):
        """Returns radius of self"""
        return self.radius
    def set_radius(self,radius):
        """radius is a number changes the radius opf self to radius"""
        self.radius = radius
    def get_area(self):
        """Returns area of circle"""
        area = self.radius * self.radius *3.14
        return area
    def equal(self, c):
        if self.radius == c.radius:
            return True
    def bigger(self,c):
        if c.radius > self.radius:
            return c
        elif c.radius < self.radius:
            return self
c1 = Circle(5)
c2 = Circle(5)