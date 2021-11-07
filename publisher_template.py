#!/usr/bin/env python

import rospy
from std_msgs.msg  import String

def main():

    # Crea un nodo ROS chiamato node_pub_chatter
    rospy.init_node("node_pub_chatter"); 

    # Oggetto Publisher: (nome del topic su cui pubblica, tipo di messaggio inviato, size buffer interno)
    pub = rospy.Publisher("topic_chatter", String ,queue_size = 10); 

    # Variabile di delay (frequenza)
    rate = rospy.Rate(10) # 10 Hz

    counter = 0;

    # while True --> not rospy.is_shutdown(): Procede fino a quando utente chiude
    while not rospy.is_shutdown():
        msg_string = f"[{rospy.get_time()}] Counter: {counter}"
        pub.publish(msg_string)
        print(f"--> Sent: {msg_string}")
        counter+=1

        # Delay 100 ms
        rate.sleep()

main()

