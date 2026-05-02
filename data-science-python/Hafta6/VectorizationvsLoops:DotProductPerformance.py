"""Question: Perform dot product on two vectors with 100,000 elements. Measure the execution time.
Perform the same operation using vectorization. Measure the execution time.
Compare the results."""

import numpy as np
from numpy import random
import time

arr1 = random.randint(10,size=100000)
arr2 = random.randint(10,size=100000)
dotProductManual = []
timeStart = time.time()
for x, y in zip(arr1, arr2):
    dotProductManual.append(x+y)
manuelTime = time.time() - timeStart
print(f"manuel time = {manuelTime:.6f}")

timeStart = time.time()
dotProductVectorized = np.add(arr1, arr2)
vectorizedTime = time.time() - timeStart
print(f"vectorized time = {vectorizedTime:.6f}")
