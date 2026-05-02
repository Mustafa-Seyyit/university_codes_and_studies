import numpy as np

# arr = np.array([22,55,66,33,44,88,12])
#
# x = [True, False, False, True,True,True,True]
#
# newarr = arr[x]
# print(newarr) Array filtering

#Question: Create a filter array
# that extracts even numbers from an array containing elements 1,2,3,4,5,6,7,8,9,10.

# arr = np.array([1,2,3,4,5,6,7,8,9,10])
# x = []
# for element in arr:
#     if element % 2 == 0:
#         x.append(True)
#     else:
#         x.append(False)
# newarr = arr[x]
# print(arr)
# print(newarr)  This is a long version


# arr = np.array([1,2,3,4,5,6,7,8,9,10])
#
# x = arr % 2 == 0
#
# newarr = arr[x]
# print(x)
# print(newarr) This is the short and efficient version