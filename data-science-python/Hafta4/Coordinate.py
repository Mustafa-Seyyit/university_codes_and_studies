import math

class Coordinate:
    def __init__(self, xval, yval):
        self.x = xval
        self.y = yval

    def distance(self, other):
        x_diff_sq = (self.x - other.x) ** 2
        y_diff_sq = (self.y - other.y) ** 2
        return math.sqrt(x_diff_sq + y_diff_sq)

    def __str__(self):
        return "<"+str(self.x)+","+str(self.y)+">"

_1 = Coordinate(1, 2)
_2 = Coordinate(4, 6)
print(_1.distance(_2))
print(_1.__str__())