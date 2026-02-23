# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        pointer = ListNode(0)
        curr = pointer
        v = 0
        while list1 or list2:
            if not list1:  
                v = list2.val
                list2 = list2.next
            elif not list2 :
                v = list1.val
                list1 = list1.next
            elif list1.val > list2.val:
                v = list2.val
                list2 = list2.next
            else:
                v = list1.val
                list1 = list1.next
            curr.next = ListNode(v)
            curr = curr.next
    
        return pointer.next
        
