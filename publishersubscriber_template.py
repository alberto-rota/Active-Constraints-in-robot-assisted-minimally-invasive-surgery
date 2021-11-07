#!/usr/bin/env python

import rospy
from std_msgs.msg  import String

pub = None;

# Implementazione della funzione di callback
def chatter_cb(msg):
    print(f"<-- Recieved: {msg}")
    pub.publish(msg.data.upper())
    # print(f"")

def main():
    global pub
    # Crea un nodo ROS chiamato node_sub_chatter
    rospy.init_node("node_sub_chatter"); 

    # Oggetto Subscriber: (nome del topic su cui pubblica, tipo di messaggio inviato, funzione di callback)
    pub = rospy.Publisher("topic_chat_uppercase", String, queue_size=10)
    sub = rospy.Subscriber("topic_chatter", String ,chatter_cb); 

    # Non ha 
    while not rospy.is_shutdown():
        pass

if __name__ == "__main__":
    main()

