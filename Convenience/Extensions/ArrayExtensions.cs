using Convenience;

namespace ArrayUtility {
    public static class ArrayExtensions {
        public static T[,] FillArray<T>(this T[,] array, T value) {
            return Array.FillArray(array, value);
        }

        public static T[,] FillRow<T>(this T[,] array, int rowId, T value) {
            return Array.FillRow(array, rowId, value);
        }

        public static T[,] FillColumn<T>(this T[,] array, int columnId, T value) {
            return Array.FillColumn(array, columnId, value);
        }

        public static string ToString<T>(this T[,] array) {
            return Array.ToString(array);
        }
    }
}
