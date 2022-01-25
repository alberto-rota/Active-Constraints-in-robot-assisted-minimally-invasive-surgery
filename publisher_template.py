##!/usr/bin/env python

import rospy
from std_msgs.msg import String  # Import the desired type of message

def main():

    # Creates a ROS node with the given name
    rospy.init_node("node_name"); 

    # The node publishes on the topic named 'topic_name' a 'String' message
    pub = rospy.Publisher("topic_name", String ,queue_size = 10); 

    # Updating frequency
    rate = rospy.Rate(10) # 10 Hz

    counter = 0;

    # while True --> not rospy.is_shutdown(): Proceeds until uses presses ctrl-C
    while not rospy.is_shutdown(): 
        msg_string = f"[{rospy.get_time()}] Counter: {counter}"
        pub.publish(msg_string)
        print(f"--> Sent: {msg_string}")
        counter+=1

        # Delays
        rate.sleep()

if __name__ == '__main__':
    main()

