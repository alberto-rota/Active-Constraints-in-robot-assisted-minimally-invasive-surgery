#!/usr/bin/env python
import rospy
from geometry_msgs.msg import PoseStamped
import numpy as np
from random import random
import math

pub = None

def update_pose(current_pose):
    print(f"POSE: {current_pose.pose.position.x},{current_pose.pose.position.x}")
    p = PoseStamped()
    p.pose.position.x = current_pose.pose.position.x+math.sin(rospy.Time.now().secs)
    p.pose.position.y = current_pose.pose.position.y+0.1
    print(f"UPDATED TO: {p.pose.position.x},{p.pose.position.x}")
    pub.publish(p)

def main():
    rospy.init_node("pose_to_unity")
    sub = rospy.Subscriber("/cubepose",PoseStamped, update_pose)
    global pub
    pub = rospy.Publisher("/cubepose_updated",PoseStamped,queue_size=10)
    rate = rospy.Rate(1)
    while not rospy.is_shutdown():
        rate.sleep()

if __name__ == "__main__":
    main()