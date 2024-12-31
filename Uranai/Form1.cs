namespace Uranai
{
    public partial class FormUranai : Form
    {
        public FormUranai()
        {
            InitializeComponent();
        }

        private void buttonUranaiStart_Click(object sender, EventArgs e)
        {
            int dateNumber; // �N�ԗݐϓ����L������ϐ�
            dateNumber = dateTimeUranai.Value.DayOfYear;    // �I�񂾓��t����A�N�ԗݐϓ����v�Z

            switch (dateNumber % 5) // �N�ԗݐϓ���5�Ŋ������]��́H
            {
                case 0: // ��g
                    pictureBoxResult.Image = Uranai.Properties.Resources.Daikichi;
                    textResult.Text = "�v�������Ƃ��R�[�h�ɂ����Ă��̂������A�v��������邩���I";
                    break;
                case 1: // ���g
                    pictureBoxResult.Image = Uranai.Properties.Resources.Cyuukichi;
                    textResult.Text = "�������R�[�h���r���h�G���[���N�����ꔭ�Ŏ��s�ł��邩���I";
                    break;
                case 2: // ���g
                    pictureBoxResult.Image = Uranai.Properties.Resources.Syoukichi;
                    textResult.Text = "�ł����I�Ǝv������R�[�h�����Y��ē����Ȃ��Ƃ��낪���邩��";
                    break;
                case 3: // �g
                    pictureBoxResult.Image = Uranai.Properties.Resources.Kichi;
                    textResult.Text = "�Ȃ��Ȃ��G���[���C���ł��Ȃ�����";
                    break;
                case 4: // ��
                    pictureBoxResult.Image = Uranai.Properties.Resources.Kyou;
                    textResult.Text = "���������������v���O�����������邩���B" + "�܂��ɂ���ځ[��Ȃ��Ƃ������邩��";
                    break;
                default:
                    pictureBoxResult.Image = null;
                    break;
            }
        }
    }
}
