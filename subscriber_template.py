#!/usr/bin/env python

import rospy
from std_msgs.msg  import String # Import the desired type of message

def callback(msg):
    print(f"<-- Recieved: {msg}")

def main():

    # Creates a ROS node with the given name
    rospy.init_node("node_name"); 

    # The node subscribes from a topic named 'topic_name' and reads a 'String' message.
    # When a message is recieved, the callback function 'callback' is called
    sub = rospy.Subscriber("topic_name", String ,callback); 

    # Nothing to do, just listening to callbacks
    while not rospy.is_shutdown():
        pass

if __name__ == "__main__":
    main()

