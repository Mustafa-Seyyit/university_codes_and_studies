
print("welcome to bmi calculator")
print("please enter your weight(kg) and height(m):")
try:
    try:
        weight = float(input())
        height = float(input())
    except:
        print("pleace enter only numbers")


    if weight <= 0:
        raise ValueError("weight cannot be negative")
    if height <= 0:
        raise ValueError("height must be positive")
    bmi = weight / height ** 2
    with open("bmi.txt", "w") as dosyam:
        if bmi < 16:
            print("Severely underweight")
        elif 16 <= bmi < 18.5:
            print("Underweight")
        elif 18.5 <= bmi < 25:
            print("Normal weight")
        elif 25 <= bmi < 30:
            print("Overweight")
        elif 30 <= bmi < 35:
            print("Moderately obese")
        elif 35 <= bmi < 40:
            print("Severely obese")
        else:
            print("Morbidly obese")
        print("Data has been saved to bmi.txt file")
except ValueError as e:
    print(f"Input error: {e}")

