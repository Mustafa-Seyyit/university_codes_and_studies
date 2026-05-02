import math


class Circle:
    def __init__(self, radius):
        self.radius = radius

    def get_radius(self):
        return self.radius

    def set_radius(self, radius):
        self.radius = radius

    def get_area(self):
        return self.radius **2 * math.pi

    def equal(self, c):
       return self.radiud == c.radius

    def bigger(self, c):
        return c if (self.radius < c.radius) else self