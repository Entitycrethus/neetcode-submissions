public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> nums1Map = new HashSet<int>(nums1);

        nums1Map.IntersectWith(nums2);

        return nums1Map.ToArray();
    }
}