#!/usr/bin/env python

import rospy
from std_msgs.msg  import String

pub = None;

def callback(msg):
    print(f"<-- Recieved: {msg}")
    pub.publish(msg)

def main():

    # Creates a ROS node with the given name
    rospy.init_node("node_name"); 

    # Both a subscriber and a publisher are initialized as standard
    # The publisher is global, must be accessed also from the callback function
    global pub
    pub = rospy.Publisher("topic_publishto", String, queue_size=10)
    sub = rospy.Subscriber("topic_readfrom", String ,callback); 

    # Nothing to do, just listening to callbacks
    while not rospy.is_shutdown():
        pass

if __name__ == "__main__":
    main()

