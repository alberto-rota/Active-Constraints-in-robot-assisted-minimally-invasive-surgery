#!/usr/bin/env python
import rospy
from geometry_msgs.msg import Pose
import numpy as np
from random import random

def publisher():
    rospy.init_node("pose_to_unity")
    pub = rospy.Publisher("/cubepose",Pose, queue_size=100)
    rate = rospy.Rate(0.1)
    while not rospy.is_shutdown():
        p = Twist()
        p.pose.position = 
        p.pose.position.x=random()*5
        p.pose.position.y=random()*5
        pub.publish(p)
        print(f"PUBLISHED: \n{p}")
        rate.sleep()
        #!clear

if __name__ == "__main__":
    publisher()