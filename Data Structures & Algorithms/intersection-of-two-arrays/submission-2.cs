public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

        HashSet<int> nums1Map = new HashSet<int> (nums1);

        HashSet<int> nums2Map = new HashSet<int> (nums2);

        nums1Map.IntersectWith(nums2Map);

        return nums1Map.ToArray();
    }
}
