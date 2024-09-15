/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    
    ListNode list3= new ListNode();
    ListNode head = list3;
    
    // Po mbaroi njera nuk krahason me
    while(list1 != null && list2 != null){

        //NQS n1(1) <= n1(2) 
        if(list1.val <= list2.val){

            //list add n1(1) list1 = list1.next else add n1(2) list2 = list2.next
            list3.next = list1;
            list1 = list1.next;
            
        }else{
            list3.next = list2;
            list2 = list2.next;
            
        }
        list3 = list3.next;
    }

    if(list1 != null){
        
        list3.next = list1;
      
    }

    if(list2 != null){
      list3.next = list2;
    }

    //

    //Kur mbaron njera fut e vlerat qe kan mbetur te tjetres
    return head.next;     
        
    }
}