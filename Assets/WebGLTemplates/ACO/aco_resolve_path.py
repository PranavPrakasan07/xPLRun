from aco import Map
from aco import AntColony

if __name__ == '__main__':

    no_of_ants, iterations, map_path, evap_rate, pher = 10, 10, "newmap.txt", 0.5, 1
    # Get the map
    Map= Map(map_path)
    Colony = AntColony(Map, no_of_ants, iterations, evap_rate, pher)
    path = Colony.calculate_path()
    print(path)

    Map.represent_path(path)
