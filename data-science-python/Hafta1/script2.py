#verilen iki nokta arasındaki öklit uzaklığını bulan python programı
class point:
    def __init__(self,x,y):
        self.x = x
        self.y = y

    def uzaklikoklit(self,x, y):
        uzaklik = ((self.x-x)**2 + (self.y-y)**2)**0.5
        return uzaklik

    def __str__(self):
        return "<"+ str(self.x)+","+str(self.y)+">" #override

    def uzaklikoklit1(self,p):
        uzaklik = ((self.x-p.x)**2 + (self.y-p.y)**2)**0.5
        return uzaklik

p1 = point(1,2)
p2 = point(4,6)

print(f"aralarındaki uzaklık : {p1.uzaklikoklit(p2.x, p2.y)}")
print(f"iki nokta arasındaki uzaklık : {p1.uzaklikoklit1(p2)}")