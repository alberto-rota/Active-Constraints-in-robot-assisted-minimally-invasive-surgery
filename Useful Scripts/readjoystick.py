## !/usr/bin/env python

import pygame
import rospy
from geometry_msgs.msg import Twist
pygame.joystick.init()
joystick_count = pygame.joystick.get_count()
print("Joystick detected: ",joystick_count>0)
joystick = pygame.joystick.Joystick(0)
print(joystick)
rospy.init_node("pose_to_unity")
pub = rospy.Publisher("/cubepose",Twist, queue_size=100)
rate = rospy.Rate(0.1)

# Prints the values for axis0
while True:
    pygame.event.get()
    axis = joystick.get_axis(0)
    print(f"A0: {axis}   /   ",end="")
    axis = joystick.get_axis(1)
    print(f"A1: {axis}   /   ",end="")
    axis = joystick.get_axis(4)
    print(f"A4: {axis}   /   ",end="")
    axis = joystick.get_axis(3)
    print(f"A3: {axis}   ///   " ,end="")
    button = joystick.get_button(7) 
    print(f"B7: {button}   /   " ,end="")      
    button = joystick.get_button(5) 
    print(f"B5: {button}" ,end="\n")       