import json

def create_map(posString):

    if posString != "":
        obstacleDictionaryString = posString

        # printing original string
        print("The original string : " + str(obstacleDictionaryString))

        obstacleDictionary = json.loads(obstacleDictionaryString)

        # print result
        print("The converted dictionary : " + str(obstacleDictionary))
        

    initialRow = "E "

    f = open("maps/newmap.txt", "w")
    f.write((initialRow*19 + "\n")*39)
    f.close()

    """
    xRight -5
    xLeft 14
    zTop -12
    zBottom 7.5
    """


if __name__ == '__main__':
    create_map("")