import json

"""
Room : 16 x 16

0-16, 0-16

"""

def create_map(posString='{ "start":[0,0], "1": [4,4], "2": [2,5], "3": [3,5], "4": [4,0], "5": [6,5], "6": [3,10], "7": [8,7],"end":[7,3]}'):

    if posString != "":
        obstacleDictionaryString = posString

        # printing original string
        print("The original string : " + str(obstacleDictionaryString))

        obstacleDictionary = json.loads(obstacleDictionaryString)

        for entry in obstacleDictionary.keys():
            lupdated = list(map(round, obstacleDictionary.get(entry)))
            obstacleDictionary[entry] = lupdated


        # print result
        print("The converted dictionary : " + str(obstacleDictionary))

    initialRow = "E "

    f = open("maps/newmap.txt", "w")
    initialRow = initialRow*16 + "\n"
    f.write(initialRow*16)

    f.close()

    """
    xRight -5
    xLeft 14
    zTop -12
    zBottom 7.5
    """

    f = open("maps/newmap.txt", "r")
    file = f.read()
    print(file)
    fileList = list(file)
    print(fileList)

    i = 0

    for value in list(obstacleDictionary.values()):
        if i == 0:
            fileList[value[0]*33 + value[1]*2] = 'S'
        elif(i != len(obstacleDictionary)-1):
            fileList[value[0]*33  + value[1]*2] = 'O'

        else:
            fileList[value[0]*33 + value[1]*2] = 'F'

        print(i, value)
        print("".join(fileList))

        i += 1
    
    f.close()

    print("Updated:")
    print("".join(fileList))

    f = open("maps/currentmap.txt", "w")
    f.write("".join(fileList))

    f.close()
