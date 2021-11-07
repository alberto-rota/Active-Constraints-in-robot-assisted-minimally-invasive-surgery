#!/usr/bin/env python

import rospy
from std_msgs.msg  import String

# Implementazione della funzione di callback
def chatter_cb(msg):
    print(f"<-- Recieved: {msg}")

def main():

    # Crea un nodo ROS chiamato node_sub_chatter
    rospy.init_node("node_sub_chatter_upppercase"); 

    # Oggetto Subscriber: (nome del topic su cui pubblica, tipo di messaggio inviato, funzione di callback)
    sub = rospy.Subscriber("topic_chat_uppercase", String ,chatter_cb); 

    # Non ha 
    while not rospy.is_shutdown():
        pass

if __name__ == "__main__":
    main()

