namespace ArraysExercise;

public static class Names
{
    /*
     * Return true if nameToFind is in the array of names,
     * and false if it isn't.
     *
     * Capital letters don't matter: "kent" finds "Kent".
     * (Hint: name.ToLower() gives you the name in lowercase.)
     *
     * HasName(["Ron", "Lisa", "Kent", "Michelle"], "Kent") -> true
     * HasName(["Ron", "Lisa", "Kent", "Michelle"], "kent") -> true
     * HasName(["Ron", "Lisa", "Kent", "Michelle"], "Jenny") -> false
     */
    public static bool HasName(string[] names, string nameToFind)
    {
        return false;
    }

    /*
     * Return how many times nameToFind is in the array of names.
     * Capital letters don't matter.
     *
     * CountName(["Ron", "Michelle", "Lisa", "Kent", "Michelle"], "Ron") -> 1
     * CountName(["Ron", "Michelle", "Lisa", "Kent", "Michelle"], "michelle") -> 2
     * CountName(["Ron", "Michelle", "Lisa", "Kent", "Michelle"], "Jenny") -> 0
     */
    public static int CountName(string[] names, string nameToFind)
    {
        return -1;
    }

    /*
     * Return a NEW array of the same size, with the same names
     * in reverse order. Don't change the array you were given.
     *
     * ReverseNames(["Ron", "Lisa", "Kent", "Michelle"]) -> ["Michelle", "Kent", "Lisa", "Ron"]
     */
    public static string[] ReverseNames(string[] names)
    {
        return [];
    }
}
