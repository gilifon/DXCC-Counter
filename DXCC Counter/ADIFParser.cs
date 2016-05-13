﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DXCC_Counter
{
    class ADIFParser
    {
        public string RawFile { get; set; }

        public IList<QSO> QSO_List { get { return _QSO_List; } }
        private IList<QSO> _QSO_List;

        //patterns
        private string address_pattern = @"<address:(\d{1,2})(?::[a-z]{1})?>";
        private string band_pattern = @"<band:(\d{1,2})(?::[a-z]{1})?>";
        private string call_pattern = @"<call:(\d{1,2})(?::[a-z]{1})?>";
        private string commant_pattern = @"<comment:(\d{1,2})(?::[a-z]{1})?>";
        private string cont_pattern = @"<cont:(\d{1,2})(?::[a-z]{1})?>";
        private string country_pattern = @"<country:(\d{1,2})(?::[a-z]{1})?>";
        private string cqz_pattern = @"<cqz:(\d{1,2})(?::[a-z]{1})?>";
        private string dxcc_pattern = @"<dxcc:(\d{1,2})(?::[a-z]{1})?>";
        private string email_pattern = @"<email:(\d{1,2})(?::[a-z]{1})?>";
        private string freq_pattern = @"<freq:(\d{1,2})(?::[a-z]{1})?>";
        private string gridsquare_pattern = @"<gridsquare:(\d{1,2})(?::[a-z]{1})?>";
        private string ituz_pattern = @"<ituz:(\d{1,2})(?::[a-z]{1})?>";
        private string mode_pattern = @"<mode:(\d{1,2})(?::[a-z]{1})?>";
        private string name_pattern = @"<name:(\d)(?::[a-z]{1})?>";
        private string pfx_pattern = @"<pfx:(\d{1,2})(?::[a-z]{1})?>";
        private string qth_pattern = @"<qth:(\d{1,2})(?::[a-z]{1})?>";
        private string rst_rcvd_pattern = @"<rst_rcvd:(\d{1,2})(?::[a-z]{1})?>";
        private string rst_sent_pattern = @"<rst_sent:(\d{1,2})(?::[a-z]{1})?>";
        private string timeoff_pattern = @"<time_off:(\d{1,2})(?::[a-z]{1})?>";
        private string timeon_pattern = @"<time_on:(\d{1,2})(?::[a-z]{1})?>";
        private string qso_date_pattern = @"<qso_date:(\d{1,2})(?::[a-z]{1})?>";

        public ADIFParser() : this("")
        {
        }

        public ADIFParser(string adif)
        {
            this.RawFile = adif;
            _QSO_List = new List<QSO>(200);
        }
        
        public bool Parse()
        {
            _QSO_List.Clear();
            //Remove Line breakers
            string oneLiner = Regex.Replace(RawFile, "\r\n", "");
            oneLiner = Regex.Replace(oneLiner, "\r", "");
            oneLiner = Regex.Replace(oneLiner, "\n", "");

            //Splite the Header
            string[] spliteHeader = Regex.Split(oneLiner, "<EOH>", RegexOptions.IgnoreCase);

            if (spliteHeader.Length < 2) return false;

            //Get the body
            string body = spliteHeader[1];

            //Splite body to lines
            string[] raw_qso_string_array = Regex.Split(body, "<EOR>", RegexOptions.IgnoreCase);

            foreach (string raw_qso in raw_qso_string_array)
            {
                //skip empty rows
                if (string.IsNullOrEmpty(raw_qso)) continue;

                QSO qso = new QSO();

                Regex regex = new Regex(address_pattern, RegexOptions.IgnoreCase);
                Match match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.address = Regex.Split(raw_qso, address_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(band_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.band = Regex.Split(raw_qso, band_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(call_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.call = Regex.Split(raw_qso, call_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(commant_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.comment = Regex.Split(raw_qso, commant_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(cont_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.cont = Regex.Split(raw_qso, cont_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(country_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.country = Regex.Split(raw_qso, country_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(cqz_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.cqz = Regex.Split(raw_qso, cqz_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(dxcc_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.dxcc = Regex.Split(raw_qso, dxcc_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(email_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.email = Regex.Split(raw_qso, email_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(freq_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.freq = Regex.Split(raw_qso, freq_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(gridsquare_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.gridsquare = Regex.Split(raw_qso, gridsquare_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(ituz_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.ituz = Regex.Split(raw_qso, ituz_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }
                
                regex = new Regex(mode_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.mode = Regex.Split(raw_qso, mode_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(name_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.name = Regex.Split(raw_qso, name_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(pfx_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.pfx = Regex.Split(raw_qso, pfx_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(qth_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.qth = Regex.Split(raw_qso, qth_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(rst_rcvd_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.rst_rcvd = Regex.Split(raw_qso, rst_rcvd_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                } 
                
                regex = new Regex(rst_sent_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.rst_sent = Regex.Split(raw_qso, rst_sent_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(timeoff_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.time_off = Regex.Split(raw_qso, timeoff_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(timeon_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.time_on = Regex.Split(raw_qso, timeon_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                regex = new Regex(qso_date_pattern, RegexOptions.IgnoreCase);
                match = regex.Match(raw_qso);
                if (match.Success)
                {
                    qso.qso_date = Regex.Split(raw_qso, qso_date_pattern, RegexOptions.IgnoreCase)[2].Substring(0, int.Parse(match.Groups[1].Value));
                }

                _QSO_List.Add(qso);
            }
            return true;
        }

    }

    internal class QSO
    {
        public string address { get; set; }
        public string band { get; set; }
        public string call { get; set; }
        public string comment { get; set; }
        public string cont { get; set; }
        public string country { get; set; }
        public string cqz { get; set; }
        public string dxcc { get; set; }
        public string email { get; set; }
        public string freq { get; set; }
        public string gridsquare { get; set; }
        public string ituz { get; set; }
        public string mode { get; set; }
        public string name { get; set; }
        public string pfx { get; set; }
        public string qth { get; set; }
        public string rst_rcvd { get; set; }
        public string rst_sent { get; set; }
        public string time_off { get; set; }
        public string time_on { get; set; }
        public string qso_date { get; set; }
    }
}