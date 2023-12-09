using UnityEngine;

public class EffectPress : MonoBehaviour
{
    public Animator[] pressEffectCurrent0, pressEffectCurrent1, pressEffectCurrent2, pressEffectCurrent3,
                        pressEffectCurrent4, pressEffectCurrent5, pressEffectCurrent6 = new Animator[5];
    
    public Submit submit;
    public KeyWord keyWord;

    public void pressEffectScale()
    {
        switch (submit.submitIndex)
        {
            case 0: // Dòng 1
                switch (keyWord.current0.Length-1)
                {
                    case 0:
                        pressEffectCurrent0[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent0[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent0[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent0[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent0[4].SetBool("Scale",true);
                        break;
                }
                break;
            
            case 1: // Dòng 2
                switch (keyWord.current1.Length-1)
                {
                    case 0:
                        pressEffectCurrent1[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent1[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent1[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent1[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent1[4].SetBool("Scale",true);
                        break;
                }
                break;
            
            case 2: // Dòng 3
                switch (keyWord.current2.Length-1)
                {
                    case 0:
                        pressEffectCurrent2[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent2[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent2[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent2[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent2[4].SetBool("Scale",true);
                        break;
                }
                break;
            
            case 3: // Dòng 4
                switch (keyWord.current3.Length-1)
                {
                    case 0:
                        pressEffectCurrent3[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent3[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent3[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent3[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent3[4].SetBool("Scale",true);
                        break;
                }
                break;
            case 4: // Dòng 5
                switch (keyWord.current4.Length-1)
                {
                    case 0:
                        pressEffectCurrent4[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent4[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent4[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent4[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent4[4].SetBool("Scale",true);
                        break;
                }
                break;
            case 5: // Dòng 6
                switch (keyWord.current5.Length-1)
                {
                    case 0:
                        pressEffectCurrent5[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent5[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent5[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent5[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent5[4].SetBool("Scale",true);
                        break;
                }
                break;            
            case 6: // Dòng 7
                switch (keyWord.current6.Length-1)
                {
                    case 0:
                        pressEffectCurrent6[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent6[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent6[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent6[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent6[4].SetBool("Scale",true);
                        break;
                }
                break;
        }
    }
    
    public void pressDeleteEffectScale()
    {
        switch (submit.submitIndex)
        {
            case 0: // Dòng 1
                switch (keyWord.current0.Length)
                {
                    case 0:
                        pressEffectCurrent0[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent0[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent0[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent0[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent0[4].SetBool("Scale",true);
                        break;
                }
                break;
            
            case 1: // Dòng 2
                switch (keyWord.current1.Length)
                {
                    case 0:
                        pressEffectCurrent1[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent1[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent1[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent1[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent1[4].SetBool("Scale",true);
                        break;
                }
                break;
            
            case 2: // Dòng 3
                switch (keyWord.current2.Length)
                {
                    case 0:
                        pressEffectCurrent2[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent2[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent2[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent2[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent2[4].SetBool("Scale",true);
                        break;
                }
                break;
            
            case 3: // Dòng 4
                switch (keyWord.current3.Length)
                {
                    case 0:
                        pressEffectCurrent3[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent3[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent3[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent3[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent3[4].SetBool("Scale",true);
                        break;
                }
                break;
            case 4: // Dòng 5
                switch (keyWord.current4.Length)
                {
                    case 0:
                        pressEffectCurrent4[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent4[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent4[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent4[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent4[4].SetBool("Scale",true);
                        break;
                }
                break;
            case 5: // Dòng 6
                switch (keyWord.current5.Length)
                {
                    case 0:
                        pressEffectCurrent5[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent5[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent5[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent5[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent5[4].SetBool("Scale",true);
                        break;
                }
                break;            
            case 6: // Dòng 7
                switch (keyWord.current6.Length)
                {
                    case 0:
                        pressEffectCurrent6[0].SetBool("Scale",true);
                        break;
                    case 1:
                        pressEffectCurrent6[1].SetBool("Scale",true);
                        break;
                    case 2:
                        pressEffectCurrent6[2].SetBool("Scale",true);
                        break;
                    case 3:
                        pressEffectCurrent6[3].SetBool("Scale",true);
                        break;
                    case 4:
                        pressEffectCurrent6[4].SetBool("Scale",true);
                        break;
                }
                break;
        }
    }
}
