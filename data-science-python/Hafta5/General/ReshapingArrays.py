import numpy as np
arr = np.array([1,2,3,4,5,6,7,8,9,10,11,12])
newarr= arr.reshape(3,4)
print(newarr)  #1D -> 2D

newarr3D = arr.reshape(2,3,2)
print(newarr3D) #1D -> 3D