﻿using UnityEngine;
using Helper;

namespace BubbleGenerator
{
    public class Bubble_Scale : StateMachineBehaviour
    {
        /* Fields */
        private GameObject m_ActualBubble;

        private float m_ScaleSteps;

        private Vector3 m_EndSize;

        private Vector3 m_ScaleStep;


        /* Methods */

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            animator.SetBool("IsScaled", false);

            m_ActualBubble = animator.gameObject.GetComponent<BubbleGenerator>().GetActualBubble();

            m_ScaleSteps = animator.gameObject.GetComponent<BubbleGenerator>().m_ScaleSteps;

            m_ScaleStep = GenerateScaleStepVector(m_ScaleSteps);

            m_EndSize = GenerateEndSize(animator.gameObject.GetComponent<BubbleGenerator>().m_EndSize);


        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {

            bool isScaled = WayCalculation.CalculateWayLeftX(m_ActualBubble.transform.localScale, m_EndSize);

            if(isScaled)
            {

                m_ActualBubble.transform.localScale += m_ScaleStep *Time.deltaTime;
            }
            else
            {
                animator.SetBool("IsScaled", true);
            }
            
            
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)  {}

        /// <summary>
        /// This method generates the scaling step vector
        /// </summary>
        /// <param name="_step">The generated scaling step vector (z-Axis)</param>
        /// <returns></returns>
        private Vector3 GenerateScaleStepVector(float _step)
        {
            return new Vector3(_step, _step, 0.0f);
        }

        /// <summary>
        /// This method generates the endsize of the scaling process
        /// </summary>
        /// <param name="_EndSize">The endsize as Vector3 (X-,Y-Axis)</param>
        /// <returns></returns>
        private Vector3 GenerateEndSize(float _EndSize)
        {
            return new Vector3(_EndSize, _EndSize, 1.0f);
        }
    }
}

